<Query Kind="Program" />

void Main()
{
	var circle=new shape();

circle.changeColor("black");
string color=circle.ShowColor("color");
Console.WriteLine(color);
}

// You can define other methods, fields, classes and namespaces here




public class shape
{
      string color{get;set;}
	  
	  public void changeColor(string clr)
	  {	 if(clr=="black")
          {
                Console.WriteLine("You are not allowed to use that color");
				return;
                
          }
	  		color=clr;
	  }
	  
	  
	  
	  public string ShowColor(string color)
	  {
	    return color;
	  }
	 
	 
}