//отправка POST-запроса с параметрами в теле

var http = require('http');
var url = require('url');
const {parse} = require('querystring');

let http_handler=(req,res)=>
{
	if(req.method=='POST')
    {
        if(url.parse(req.url).pathname === '/threepar'){

            let body='';
            req.on('data',chunk=>{body+=chunk.toString();});
            req.on('end',()=>{
                let o = parse(body);
                let result = `x+y+s=${o['x']+o['y']+o['s']}`
                
                res.writeHead(200,{'Content-Type': 'text/html;charset=utf-8'});
                res.end(result);
                console.log(result);
            });
		}
    }
}
var server=http.createServer(function (req, res){
    http_handler(req,res);
}).listen(5000);