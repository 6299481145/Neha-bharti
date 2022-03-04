package com.nehu.jdbc.hostel;
import java.sql.*;
import java.util.Scanner;

public class Room{
    private String roomno;
    private String type;

    void newRoom() {
        Scanner scan = new Scanner(System.in);
        System.out.print("Room Number: ");
        roomno = scan.nextLine();
        System.out.print("Room Type: ");
        type = scan.nextLine();

        Support support = new Support();
        try {
            Connection con = DriverManager.getConnection(support.getURL(), support.getUser(), support.getPassword());
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
    }
    void editRoom(String roomno) {

    }

}