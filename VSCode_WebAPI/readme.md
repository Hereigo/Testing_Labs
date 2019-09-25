### To get json from api :
c:\curl\curl -k -s https://localhost:5001/api/products | C:\curl\jq 
(JS is https://stedolan.github.io/jq/)


### To kill all dotnet processes in case of exceptions :
kill $(pidof dotnet)


### POST insert :
c:\curl\curl -i -k -H "Content-Type: application/json" -d "{'name':'Plush Squirrel','price':0.00}" https://localhost:5001/api/Products  

> -i info about the HTTP response headers.   
> -d defines the request body to implies an HTTP POST operation.   
> -H indicates that the request body is in JSON format. (overrides the default content type of application/x-www-form-urlencoded)   


...
