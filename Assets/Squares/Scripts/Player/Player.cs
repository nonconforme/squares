﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Player : ITileOccupant {

	public string name;
	public int id;
	public Tile.Color color;
	public int totalSquares = 0;
	public int life = 20;

	public OwnerType ownerType;
	public BoardSide boardSide;
	public Domain domain;

	public Tile homeTile;

	public void ReclaimSquare (Square square) {
		totalSquares++;
	}

	public override string ToString ()
	{
		return string.Format ("[Player] id: " + id + " name: " + name);
	}

}
