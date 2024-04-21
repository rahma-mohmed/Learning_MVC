﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Principal;
using TaskIT.Models;
using TaskIT.Services;

namespace TaskIT.Controllers
{
    public class BookController : Controller
    {
        BookRepository BookServices = new BookRepository();


        public IActionResult Index()
        {
            return RedirectToAction("Index" , "Home");
        }

        public IActionResult Add()
        {
            Book Bk = new Book();
            return View(Bk);
        }

        public IActionResult SaveAdd(Book newBook)
        {
            if (ModelState.IsValid == true)
            {
                BookServices.Create(newBook);
                return RedirectToAction("Index");
            }

            return View("Add", newBook);
        }

        public IActionResult Edit(int id)
        {
            Book book = BookServices.getById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult SaveEdit([FromRoute] int id, Book book)
        {
            if (ModelState.IsValid)
            {
                BookServices.Update(id, book);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Confirm_delete(int id)
        {
            Book book = BookServices.getById(id);
            return View(book);
        }

        public IActionResult Delete(int id)
        {
            BookServices.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Back()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Book book = BookServices.getById(id);
            return View(book);
        }

    }
}
