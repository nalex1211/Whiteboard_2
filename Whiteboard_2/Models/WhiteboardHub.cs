using Microsoft.AspNetCore.SignalR;
using Whiteboard_2.Models;

public class WhiteboardHub : Hub
{
    public async Task SendDrawing(DrawingData data)
    {
        await Clients.All.SendAsync("ReceiveDrawing", data);
    }
}
