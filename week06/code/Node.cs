using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Contracts;


public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data)
        {
            return;
        }

        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
                
            else
                Left.Insert(value);
                
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
                
        }   
        
        
    }

    public bool Contains(int value) {
        //TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            if (Left != null)
            {
               return Left.Contains(value); 
            }
            
        }
        else
        {
            if (Right != null)
            {
               return Right!.Contains(value); 
            }
            
        }
        return false;
               
    }

    public int GetHeight() {
        // TODO Start Problem 4
        // var left = Left;
        // var right = Right;
        // if (left! > right!)
        // {
        //     return Left!.GetHeight() + 1;
        // }
        // else
        //     return Right!.GetHeight() + 1;  

        return 0;    
        // Replace this line with the correct return statement(s)
    }

}