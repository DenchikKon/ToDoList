﻿namespace ToDoList.Models
{
	public class Tasks
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsCompleted { get; set; }
		public DateTime dateCreate { get; set; }

	}
}
