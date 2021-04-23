using System;

public class Contenedor: Canvas
{
	private int x, y;
	private bool isClicked;
	public Contenedor()
	{
		x, y = 30;
		isClicked = false;
	}

	public void paint(Graphics g) {
		g.setColor(ConsoleColor.Yellow)
	}
}
