using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace DrawWithSignalR
{
    public class DrawHub:Hub
    {
        public void Draw(int previousX,int previousY ,int currentX,int currentY)
        {
            this.Clients.All.DrawOnClient(previousX, previousY, currentX, currentY);
        }
        public void DrawDot(int currentX, int currentY)
        {   
            this.Clients.All.DrawDotOnClient(currentX, currentY);
        }

        public void DrawImage(string imagePath)
        {
            this.Clients.Others.DrawImageOnClient(imagePath);
        }

    }
}