/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication3;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author freese
 */
public class DeliveryThread implements Runnable {

    private Socket s;
    private DataInputStream read;
    private DataOutputStream write;
    
    public DeliveryThread(Socket s)
    {
        this.s = s;
        try {
            read = new DataInputStream(this.s.getInputStream());
            write = new DataOutputStream(this.s.getOutputStream());
        } catch (IOException ex) {
            Logger.getLogger(AdminThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    @Override
    public void run() {
        try {
            StringBuilder sb = new StringBuilder();
            for(Picture p : CustomerThread.c.BoughtPictures)
            {
                sb.append(p.ID).append('\n');
            }
            sb.append("To address: ").append(CustomerThread.c.Address);
            write.writeUTF(sb.toString());
        } catch (IOException ex) {
            Logger.getLogger(DeliveryThread.class.getName()).log(Level.SEVERE, null, ex);
        }

    }
    
}
