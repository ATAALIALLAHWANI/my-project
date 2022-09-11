
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication3;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author freese
 */
public class Customer {
    public int ID = 1;
    public String First_Name;
    public String Last_Name;
    public String City;
    public String Country;
    public String Username;
    public String Password;
    public String Address;
    public List<Picture> BoughtPictures = new ArrayList<>();
}
