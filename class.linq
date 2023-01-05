<Query Kind="Program" />

void Main()
{
  var square=new box();
  square.show();
}

 public class box
{

   string shape{get;set;}
   float height{get;set;}
   float width{get;set;}
   string color{get;set;}
   
     public box()
	 {
	   this.shape="square";
	   this.height=10;
	   this.width=10;
	   this.color="black";
	 }
	 
	 
	 public void show()
	 {
	   Console.WriteLine("shape:"+this.shape);
	   Console.WriteLine("height:"+this.height);
	   Console.WriteLine("width:"+this.width);
	   Console.WriteLine("color:"+this.color);
	 }
   
}

// You can define other methods, fields, classes and namespaces here