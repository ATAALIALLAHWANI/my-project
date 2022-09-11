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
public class AdminThread implements Runnable {
    private Socket s;
    private DataInputStream read;
    private DataOutputStream write;
    
    public AdminThread(Socket s)
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
            int choice = Integer.MIN_VALUE;
            do{
                String menu = "1) Add Picture\n"
                + "2) Delete Picture\n"
                + "3) Delete Customer\n"
                + "0) Exit";
                write.writeUTF(menu);
                choice = read.read();
                switch(choice)
                {
                    case 1:
                        AddPicture();
                        break;
                    case 2:
                        DeletePicture();
                        break;
                    case 3:
                        DeleteCustomer();
                        break;
                    case 0:
                        s.close();
                        return;
                }
                
            } while(choice != 0);
            
            
        } catch (IOException ex) {
            Logger.getLogger(AdminThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void AddPicture() {
        try {
            Picture pic = new Picture();
            pic.ID = Server.availablePictures.size() + 1;
            write.writeUTF("Picture Name:");
            pic.picture_Name = read.readUTF();
            
            write.writeUTF("Painter Name:");
            pic.Painter = read.readUTF();
            
            write.writeUTF("Price:");
            pic.Price = read.readDouble();
            
            write.writeUTF("Discount: ");
            pic.Discount = read.readDouble();
            
            write.writeUTF("Status (Available, Unavailable):");
            String status = read.readUTF();
            switch(status.toLowerCase())
            {
                case "available":
                    pic.status = Picture.Status.Available;
                    break;
                case "unavailable":
                    pic.status = Picture.Status.Unavailable;
                    break;
            }
            
            Server.availablePictures.add(pic);
            
        } catch (IOException ex) {
            Logger.getLogger(AdminThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void DeletePicture() {
        try {
            StringBuilder allPics = new StringBuilder();
            for(int i=0; i<Server.availablePictures.size(); i++)
            {
                Picture pic = Server.availablePictures.get(i);
                allPics.append(i).append(")").append(pic).append("=========\n");
            }
            write.writeUTF(allPics.toString());
            int choice = read.read();
 
            Server.availablePictures.remove(choice - 1);
        } catch (IOException ex) {
            Logger.getLogger(AdminThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void DeleteCustomer() {
        try { 
            Server.Sockets.get(Server.CustomerSocketIndex).close();
            write.writeUTF("Customer Deleted");
        } catch (IOException ex) {
            Logger.getLogger(AdminThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
