﻿using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    public IActionResult Product()
    {
        return View("Product"); 
    }
}
