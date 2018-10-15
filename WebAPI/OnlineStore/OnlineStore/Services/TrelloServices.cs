using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Models.RequestAllBoards;
using OnlineStore.Models.RequestLists;

namespace OnlineStore.Services
{
    public class TrelloServices
    {
        string _devkey;
        string _token;
        HttpServices _httpServices = new HttpServices();

        public TrelloServices(string devkey, string token)
        {
            _devkey = devkey;
            _token = token;
        }
        public async Task<List<TrelloRoot>>GetAllBoards()
        {
            //string url = $"https://api.trello.com/1/boards/560bf4298b3dda300c18d09c?fields=name,url&key={"e26b7782f53f2ea086c146f9fd1a8a56"}&token={"eb79eeb486baf153bb4d1c705e02a17e13c9d5133404ef2d773000cd2c6adbfa"}";
            string url = $"https://api.trello.com/1/members/me/boards?key={_devkey}&token={_token}";
            string result = await _httpServices.Get(url);
            return JsonConvert.DeserializeObject<List<TrelloRoot>>(result);
        }

        internal async Task<List<TrelloList>> GetAllListForBoard(string id)
        {
            string url = $"https://api.trello.com/1/boards/{id}/list?=key={_devkey}&token={_token}";
            string result = await _httpServices.Get(url);
            return JsonConvert.DeserializeObject<List<TrelloList>>(result);
        }
    }
}
