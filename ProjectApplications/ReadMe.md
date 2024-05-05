# Complex Api Scenarios

1- Designing Associations (sub-object-use URL navigation)
    eg - api/cutomers/123/invoices
    eg - api/customers?st=GA
2- Associations in action
3- Paging
    -List should support paging
    -Query string are commonly used: /api/tickets?page=1&page_size=25
    -use wrapper to recive
4- Designing Error Handling
    return obj with status code
5- Caching
    -basic tenet of REST api
    -server-side caching is good
    -but isn't what they mean(client side caching)
    -use http for caching mechanism
6- Functional API
    -Be pragmatic
    -Make sure these are documented
    -should be completely functional
7- Async API solution to consider
    -Comet
    -gRPC
    -SignalR
    -Firebase
    -Socket.IO
    -Etc
8- 
