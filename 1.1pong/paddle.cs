using Godot;
using System;

public partial class paddle : Area2D
{	
	[Export]
	public int Speed {get; set;} = 400;
	
	public Vector2 ScreenSize;
	public Vector2 PaddleSize;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
		PaddleSize = GetNode<CollisionShape2D>("CollisionShape2D").Shape.GetRect().Size;
		GD.Print(PaddleSize);
		GD.Print("PaddleSize");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{	
		int velocity = 0;
		
		if (Input.IsActionPressed("move_up")){
			velocity -= Speed;
		}
		else if (Input.IsActionPressed("move_down")){
			velocity += Speed;
		}

		
		var PositionY = Position.Y + velocity * (float)delta;
		Position = new Vector2(
			x : 0,
			y : Mathf.Clamp(PositionY, 0 + PaddleSize.Y/2, ScreenSize.Y - PaddleSize.Y/2)
			
		);
		
		
		
	  
	}
}
