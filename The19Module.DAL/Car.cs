﻿using System;
using System.Collections.Generic;

namespace The19Module.DAL;

public partial class Car
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Model { get; set; }

    public double? Speed { get; set; }

    public decimal? Price { get; set; }

    public int? TypeCar { get; set; }
}
