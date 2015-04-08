package com.paul.gifts.classes;

import java.util.ArrayList;

/**
 * Created by 1 on 08.04.2015.
 */
public class Gift {

    private ArrayList<Product> constituents;
    private final static Creator[] creators = {new PackingCreator(),new ConfectionCreator()};
    
    public Gift(){
        constituents = new ArrayList<>();
        for (Creator creator: creators){
           constituents.add(creator.factoryMethod()); 
        }
    }

    public ArrayList<Product>  getConstituents() {
        return constituents;
    }
}
