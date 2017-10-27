using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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