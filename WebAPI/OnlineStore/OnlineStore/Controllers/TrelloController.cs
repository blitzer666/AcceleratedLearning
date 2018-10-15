using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models.RequestAllBoards;
using OnlineStore.Services;
using OnlineStore.Models.RequestLists;

namespace OnlineStore.Controllers
{
    public class TrelloController : Controller
    {
        TrelloServices _trelloService;

        public TrelloController()
        {
            _trelloService = new TrelloServices("e26b7782f53f2ea086c146f9fd1a8a56", "eb79eeb486baf153bb4d1c705e02a17e13c9d5133404ef2d773000cd2c6adbfa");
        }
        public async Task<IActionResult> Index()
        {
            List<TrelloRoot> result = await _trelloService.GetAllBoards();
            return View(result);
        }
        public async Task<IActionResult> Board(string id)
        {
            List<TrelloList> result = await _trelloService.GetAllListForBoard(id);
            return View (result);
            //return Ok("Du vill se listor för boarden " + id);
        }
    }
}