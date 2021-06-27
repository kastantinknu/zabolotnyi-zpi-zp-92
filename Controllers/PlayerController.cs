﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Football_manager.Models;

namespace Football_manager.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository repository;
        public PlayerController(IPlayerRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Players.ToList<Player>());
        //// GET: PlayerController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: PlayerController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: PlayerController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: PlayerController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PlayerController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: PlayerController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PlayerController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PlayerController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
