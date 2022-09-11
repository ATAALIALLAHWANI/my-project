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
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author freese
 */
public class client2 {
    private static Scanner sc = new Scanner(System.in);
    private static DataInputStream read;
    private static DataOutputStream write;
    private static Socket s;
    public static void main(String[] args)
    {
        try {
            s = new Socket("localhost", 3000);
            read = new DataInputStream(s.getInputStream());
            write = new DataOutputStream(s.getOutputStream());

            //Menu
            System.out.println(read.readUTF());
            //Choice
            int choice = sc.nextInt();
            write.write(choice);
            
            switch(choice)
            {
                case 1:
                    HandleAdmin();
                    break;
                case 2:
                    HandleCustomer();
                    break;
                case 3:
                    HandleDelivery();
                    break;
            }
            
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void HandleAdmin() {
        int choice = Integer.MIN_VALUE;
        do{
            try {
                System.out.println(read.readUTF());
                choice = sc.nextInt();
                write.write(choice);
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
                }
            } catch (IOException ex) {
                Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
            }
        } while(choice != 0);
    }

    private static void HandleCustomer() {
        try {
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());

            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            int choice = Integer.MIN_VALUE;
            do{
                System.out.println(read.readUTF());
                choice = sc.nextInt();
                write.write(choice);
                
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
                
            }while(choice != 0);
            
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void HandleDelivery() {
        try {
            System.out.println(read.readUTF());
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void AddPicture() {
        try {
            //Picture name
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            //Painter name
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
            //Price
            System.out.println(read.readUTF());
            write.writeDouble(sc.nextDouble());
            
            //Discount
            System.out.println(read.readUTF());
            write.writeDouble(sc.nextDouble());
            
            //Status
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
            
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void DeletePicture() {
        try {
            System.out.println(read.readUTF());
            write.write(sc.nextInt());
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void DeleteCustomer() {
        try {
            System.out.println(read.readUTF());
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void BuyPicture() {
        try {
            System.out.println(read.readUTF());
            write.write(sc.nextInt());
            
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static void Checkout() {
        try {
            System.out.println(read.readUTF());
            write.writeUTF(sc.next());
             
            System.out.println(read.readUTF());
        } catch (IOException ex) {
            Logger.getLogger(client1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
