using System;
using System.Collections.Generic;

 class GameObject 
{
	private int id;
    private bool isActive; 
    private string name;
    private List<string> components= new List<string>(); 
	
	public void CreateComponent(string Component){
		this.components.Add(Component);
	}
	 
	public void PrintAllComponents(){
	
        foreach(string k in components)
        {
            Console.WriteLine(k);
        }
	}
	 
	public bool GetComponent(string Component){
		return this.components.Contains(Component);
	}
	 
	public virtual string  GetName(){
		return this.name;
	}
	 
	public void SetName(string name){
		this.name=name;
	}
	 
	public void SetIsActive(bool isActive){
		this.isActive=isActive;
	}
	
}
	
 class Transform : GameObject{
	 
	 private int positionX; 
	 private int positionY;
	 
   
	 public void Translate(){
	  this.positionX=this.positionX+1;
	  this.positionY=this.positionY+1;
	 }
	 
	 public int GetXPosition(){
		 return this.positionX;
	 }
   
	 public int GetYPosition(){
		 return this.positionY;
	 }
	 
	 public override string GetName(){
	  return"I am a Transform";
	 }
	
}
	
	
public class program{
	public static void Main()
	{
		GameObject gameObject=new GameObject();
		Transform transform= new Transform();
		
		gameObject.CreateComponent("Mesh Filter ");
		gameObject.CreateComponent("Mesh Renderer");
		gameObject.CreateComponent("Box Collider");
		Console.WriteLine("The Game Object Components is: ");
		gameObject.PrintAllComponents();
		Console.WriteLine("IS component Light in the components List: "+gameObject.GetComponent("Light"));//return false
		Console.WriteLine("IS component Mesh Renderer in the components List: "+gameObject.GetComponent("Mesh Renderer"));//return true
		gameObject.SetName("cube");
		Console.WriteLine("the GameObject is :"+gameObject.GetName());
		
		transform.Translate();
        Console.WriteLine(transform.GetName());	 
		Console.WriteLine("Object transform in x and y position as ("+ transform.GetXPosition()+":"+transform.GetYPosition()+")");
	}
}
