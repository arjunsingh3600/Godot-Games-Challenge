using Godot;
using System;

public partial class CpuPaddle : Area2D
{
	// Called when the node enters the scene tree for the first time.

	[Export]
	public int Speed {get; set;} = 400;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
