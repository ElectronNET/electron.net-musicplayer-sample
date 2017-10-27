using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectronNET.API;
using ElectronNET.API.Entities;
using System.IO;
using System.Collections.Generic;

namespace MyElectronMusicPlayer.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            string musicPath = await Electron.App.GetPathAsync(PathName.music);
            string[] mp3Files = Directory.GetFiles(musicPath, "*.mp3", SearchOption.TopDirectoryOnly);
            string[] mp4Files = Directory.GetFiles(musicPath, "*.mp4", SearchOption.TopDirectoryOnly);

            List<string> musicFiles = new List<string>();
            musicFiles.AddRange(mp3Files);
            musicFiles.AddRange(mp4Files);

            return View(musicFiles);
        }
    }
}