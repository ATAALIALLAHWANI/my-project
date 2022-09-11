/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication3;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author freese
 */
public class Server {

    public static List<Picture> availablePictures = new ArrayList<>();
    public static List<DataInputStream> read = new ArrayList<>();
    public static List<DataOutputStream> write = new ArrayList<>();
    public static int CustomerSocketIndex;
    public static List<Socket> Sockets = new ArrayList<>();

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            ServerSocket ss = new ServerSocket(3000);
            for(int i = 0; i < 3; i++)
            {
               Socket s = ss.accept();
                Sockets.add(s);
            }
            
            //Fill datainput and dataoutput for each socket
            for (int i = 0; i < 3; i++) {
                read.add(new DataInputStream(Sockets.get(i).getInputStream()));
            }
            
            for (int i = 0; i < 3; i++) {
                write.add(new DataOutputStream(Sockets.get(i).getOutputStream()));
            }
            
            //Send the menu to each client/socket
            String startMenu = "1) Admin\n"
                    + "2) Customer\n"
                    + "3) Delivery\n";
            for (int i = 0; i < 3; i++) {
                write.get(i).writeUTF(startMenu);
            }
            
            List<Integer> choices = new ArrayList<>();
            for (int i = 0; i < 3; i++) {
                choices.add(read.get(i).read());
            }
            
            for(int i = 0; i < choices.size(); i++)
            {
                switch(choices.get(i))
                {
                    case 1:
                        AdminThread at = new AdminThread(Sockets.get(i));
                        Thread t = new Thread(at);
                        t.start();
                        break;
                    case 2:
                        CustomerThread ct = new CustomerThread(Sockets.get(i));
                        CustomerSocketIndex = i;
                        t = new Thread(ct);
                        t.start();
                        break;
                    case 3:
                        DeliveryThread dt = new DeliveryThread(Sockets.get(i));
                        CustomerSocketIndex = i;
                        t = new Thread(dt);
                        t.start();
                        break;
                }
            }
            
            Thread.currentThread().wait();
            
        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        } catch (InterruptedException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
