/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication3;

/**
 *
 * @author freese
 */
public class Picture {
    public enum Status
    {
        Available,
        Unavailable
    }
    public int ID;
    public String picture_Name;
    public String Painter;
    public double Price;
    public double Discount; //percentage, can be 2.5%
    public Status status;
    
    @Override
    public String toString()
    {
        return "ID: " + ID + "\n"
            + "Name: " + picture_Name + "\n"
            + "Painter: " + Painter + "\n"
            + "Price: " + Price + "\n"
            + "Discount: " + Discount + "\n"
            + "Status: " + status + "\n";
    }
}
