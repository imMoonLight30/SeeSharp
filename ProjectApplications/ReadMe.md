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

## Versioning Your REST Api

## api and seurity

personal data, token, 
-protect you API
    -secure in-transit
        -SSl is almost always appropiate
        -cost of SSL worth
    -Cross domain security
        -by default, not allowed
            -but only in browser
        Public or private API?
            -PUBLIC: should allow
            -Private: Consider for partner
        -CORS(cross-origin-resouce sharing)
            -allow control finely grained control
            -Domain, resouce
            - selected browser
        How Does CORS work?
            -> request-> browser requests access -> server request -> browser issue reply
        -Authentication vs Authorization
            -who you are , what you can do
            -credentials(tokens, user/pass) , rules about rights(claims, roles, rights)
            -Authentication types of apis
                -app authentication
                    -identifly
                -User authentication
                -use -> cookies, token auth, oauth2.0, basic auth
                    -Cookies: 
                        -Cookies are easy, con't i use them?
                            - yes - easies and common
                            -subject to request forgery
                            -Depends on your security needs
                    -Basic Auth:
                        -easy to impliment
                        -but not secure, unless enforcing SSL
                        -risky still
                            -send credential on every request
                    -Token-based auth
                        -Typical for APIs
                            -mix of secure and simplicity
                        -industry-standard tokens are easy
                        -should expire much faster than cookies.
                        -eg : JWTs(json web tokens)
                    -OAuth:
                        -use trusted third-party to identify
                        -you never receive credentials
                            -use token to confirm identity
                            -safer for you and user

