﻿using System;
namespace Business.Dtos.Responses;

public class CreatedBrandResponse
{
	public int Id { get; set; }
	public string Name { get; set; }
	public DateTime CreatedDate { get; set; }
}