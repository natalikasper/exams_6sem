using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;

namespace Lab2b.Handlers
{
    
    public class Websocket : IHttpHandler
    {
        // Блокировка для обеспечения потокобезопасности
        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
                context.AcceptWebSocketRequest(WebSocketRequest);
        }
        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            // Получаем сокет клиента из контекста запроса
            var socket = context.WebSocket;
            
            // Слушаем его
            while (true)
            {
                byte[] str = Encoding.Default.GetBytes("Hello from WS Server!!");
                ArraySegment<byte> buffer = new ArraySegment<byte>(str);
                if (socket.State == WebSocketState.Open)
                {
                    await socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
                }
                Thread.Sleep(1000);
            }

        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}