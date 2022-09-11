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
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author freese
 */
public class CustomerThread implements Runnable {

    private Socket s;
    private DataInputStream read;
    private DataOutputStream write;
    public static final Customer c = new Customer();
    public CustomerThread(Socket s)
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
            write.writeUTF("Enter First Name:");
            c.First_Name = read.readUTF();
            
            write.writeUTF("Enter Last Name:");
            c.Last_Name = read.readUTF();
            
            write.writeUTF("Enter City:");
            c.City = read.readUTF();
            
            write.writeUTF("Enter Country:");
            c.Country= read.readUTF();
            
            write.writeUTF("Enter Address:");
            c.Address = read.readUTF();
            
            write.writeUTF("Enter Username:");
            c.Username = read.readUTF();
            
            write.writeUTF("Enter Password:");
            c.Password = read.readUTF();
            
            write.writeUTF("Please Enter Username:");
            String username = read.readUTF();
         
            write.writeUTF("Please Enter password:");
            String password = read.readUTF();
            
            if (!password.equals(c.Password) || !username.equals(c.Username)) {
                //Wrong password
                s.close();
            }
            
            int choice = Integer.MIN_VALUE;
            do{
                String menu = "1) Buy Picture\n"
                        + "2) Checkout"
                        + "0) Exit";
                write.writeUTF(menu);
                choice = read.read();
                switch(choice)
                {
                    case 1:
                        BuyPicture();
                        break;
                    case 2:
                        Checkout();
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

    private void BuyPicture() {
        try {
            StringBuilder allPics = new StringBuilder();
            List<Picture> availablePics = Server.availablePictures;
            int counter = 0;
            for(int i=0; i<availablePics.size(); i++)
            {
                Picture pic = availablePics.get(i);
                if (pic.status == Picture.Status.Available) {
                    counter++;
                    allPics.append(counter).append(")").append(pic).append("=========\n");
                }
                else
                {
                    availablePics.remove(pic);
                }
            }
            write.writeUTF(allPics.toString());
            int choice = read.read();
            Picture currentPic = availablePics.get(choice - 1);

            int index = Server.availablePictures.indexOf(currentPic);
            Server.availablePictures.get(index).status = 
                    Picture.Status.Unavailable;
            c.BoughtPictures.add(currentPic);
        } catch (IOException ex) {
            Logger.getLogger(CustomerThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void Checkout() {

        try {
            write.writeUTF("Enter Credit Card Number:");
            read.readUTF();
            double finalPrice = 0;
            if (c.BoughtPictures.size() > 1) {
                for(Picture pic : c.BoughtPictures)
                {
                    finalPrice = pic.Price * (pic.Discount + 5.0);
                }
            }
            else
            {
                for(Picture pic : c.BoughtPictures)
                {
                    finalPrice = pic.Price * pic.Discount;
                }            }
            write.writeUTF("You payed: " + finalPrice);
        } catch (IOException ex) {
            Logger.getLogger(CustomerThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
