
<a name='Microsoft.AspNetCore.Http.HttpContextExtensions'></a>

## Microsoft.AspNetCore.Http.HttpContextExtensions
Extension methods for existing HttpContext types.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### GetAbsoluteUri(this HttpContext httpContext)

Method to return Absolute Uri for HttpContext

|Parameters| |
| - | - |
|httpContext|this HttpContext|

#### Returns:
Uri 
## 
#### GetAbsoluteDomain(this HttpContext httpContext)

Method to return Absolute Domain for HttpContext

|Parameters| |
| - | - |
|httpContext|this HttpContext|

#### Returns:
string 
## 
#### GetAbsoluteUrl(this HttpContext httpContext)

Similar methods for Url/AbsolutePath which internally call GetAbsoluteUri

|Parameters| |
| - | - |
|httpContext|this HttpContext|

#### Returns:
string 
## 
#### GetAbsolutePath(this HttpContext httpContext)

Method to return Absolute Path HttpContext

|Parameters| |
| - | - |
|httpContext|this HttpContext|

#### Returns:
string 
## 
#### IsAjaxRequest(this HttpContext httpContext)

Method to return if HttpContext is an AJax request

|Parameters| |
| - | - |
|httpContext|this HttpContext|

#### Returns:
bool 
## 
#### GetRemoteAddress(this HttpContext httpContext)

Method to return IPAddress of reomote address for HttpContext

|Parameters| |
| - | - |
|httpContext|HttpContext|

#### Returns:
IPAddress 
## 

( [Home](Home) )


<a name='Microsoft.AspNetCore.Http.HttpRequestExtensions'></a>

## Microsoft.AspNetCore.Http.HttpRequestExtensions
Extension methods for existing HttpRequest types.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### IsLocalUrl(this HttpRequest request, string url)

Method to determine if string is a local url

|Parameters| |
| - | - |
|request|this HttpRequest|
|url|string|

#### Returns:
bool 
## 
#### GetUri(this HttpRequest request)

Method to return Uri of HttpRequest

|Parameters| |
| - | - |
|request|this HttpRequest|

#### Returns:
bool 
## 
#### GetRemoteAddress(this IPAddress ipAddress)

Method to return IPAddress of reomote address for HttpRequest

|Parameters| |
| - | - |
|request|HttpRequest|

#### Returns:
IPAddress 
## 
#### IsAjaxRequest(this HttpRequest httpRequest)

Method to return if HttpRequest is an AJax request

|Parameters| |
| - | - |
|httpRequest|this HttpRequest|

#### Returns:
bool 
## 

( [Home](Home) )


<a name='System.Net.IPAddressExtensions'></a>

## System.Net.IPAddressExtensions
Extension methods for existing IPAddress types.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### GetRemoteAddress(this IPAddress ipAddress)

Method to return IPAddress of reomote address of supplied HttpRequest

|Parameters| |
| - | - |
|ipAddress|this IPAddress|
|request|HttpRequest|

#### Returns:
IPAddress 
## 
#### IsInternalRequest(this IPAddress ipAddress)

An extension method to determine if an IP address is internal, as specified in RFC1918

|Parameters| |
| - | - |
|ipAddress|The IP address that will be tested|

#### Returns:
Returns true if the IP is internal, false if it is external 
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Html.StatusCodes'></a>

## HomeSite.ClassLibrary.Web.Html.StatusCodes
Class for returning defintion of given Html status code

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### GetCodeDefinition(int code)



|Parameters| |
| - | - |
|code|int|

#### Returns:
KeyValuePair\<int, string\> 
## 
#### ToString(int code)



|Parameters| |
| - | - |
|code|int|

#### Returns:
string 
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Html.Tags'></a>

## HomeSite.ClassLibrary.Web.Html.Tags
Class to return string of Html tag.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### LineBreak()

Method to return one new line

#### Returns:
string 
## 
#### LineBreak(int count)

Method to return multple new lines

|Parameters| |
| - | - |
|count|int|

#### Returns:
string 
## 
#### Space()

Method to return one space

#### Returns:
string 
## 
#### Space(int count)

Method to return multipe spaces

|Parameters| |
| - | - |
|count|int|

#### Returns:
string 
## 
#### Brackets(string item)

Method to wrap given string in brakets

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Bold(string item)

Method to wrap given string in bold tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Italic(string item)

Method to wrap given string in italic tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Important(string item)

Method to wrap given string in strong tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Emphasized(string item)

Method to wrap given string in em tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Marked(string item)

Method to wrap given string in mark tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Small(string item)

Method to wrap given string in small tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Deleted(string item)

Method to wrap given string in del tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Inserted(string item)

Method to wrap given string in ins tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Subscript(string item)

Method to wrap given string in sub tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Superscript(string item)

Method to wrap given string in sup tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Quote(string item)

Method to wrap given string in q tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### BlockQuote(string item, string cite)

Method to wrap given string in blockquote tags with given citing

|Parameters| |
| - | - |
|item|string|
|cite|string|

#### Returns:
string 
## 
#### Abbreviation(string item)

Method to wrap given string in abbr tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Address(string item)

Method to wrap given string in address tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Cite(string item)

Method to wrap given string in cite tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### BidirectionalOverride(string item)

Method to wrap given string in bdo tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 
#### Paragraph(string item)

Method to wrap given string in p tags

|Parameters| |
| - | - |
|item|string|

#### Returns:
string 
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Http.ApplicationCookie'></a>

## HomeSite.ClassLibrary.Web.Http.ApplicationCookie
Cookie class

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### ApplicationCookie(IHttpContextAccessor httpContextAccessor)

Initializes a new instance reading, writing or removing cookie
## 
#### ApplicationCookie(IHttpContextAccessor httpContextAccessor, CookieOptions cookieOptions)

Initializes a new instance reading, writing or removing cookie
## 
#### GetValue(string cookieKey, string key)

Method to return value for given key in dictonary stored in cookie

|Parameters| |
| - | - |
|cookieKey|string|
|key|string|

#### Returns:
string 

#### Exceptions:
 ( Requires HttpRequest )
## 
#### GetAllValues(string sessionkey)

Method to return dictionary of values for given key stored in cookie

|Parameters| |
| - | - |
|cookieKey|string|

#### Returns:
Dictionary<string, string%gt; 

#### Exceptions:
 ( Requires HttpRequest )
## 
#### SetValue(string cookiekey, string key, string value)

Method to save a record in a dictonary of key value records in cookie

|Parameters| |
| - | - |
|cookieKey|string|
|key|string|
|value|string|

#### Exceptions:
 ( Requires HttpRequest and HttpResponse )
## 
#### SetAllValues(string cookiekey, Dictionary<string, string>)

Method to save a dictonary of key value records in cookie

|Parameters| |
| - | - |
|cookieKey|string|
|values|Dictionary<string, string>|

#### Exceptions:
 ( Requires HttpRequest and HttpResponse )
## 
#### Remove(string cookiekey)

Delete the cookie

|Parameters| |
| - | - |
|cookieKey|string|

#### Exceptions:
 ( Requires HttpResponse )
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Controllers.WebBaseController'></a>

## HomeSite.ClassLibrary.Web.Mvc.Controllers.WebBaseController
Base controller class for web application

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/17/2020 | Initial build |


|Fields| |
| - | - |
|_logger|ILogger|
|_webHostEnvironment|IWebHostEnvironment|
|_httpContextAccessor|IWebHostEnvironment|

### Methods:
#### WebBaseController(ILogger<T> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)

Constructor method

|Parameters| |
| - | - |
|logger|ILogger|
|webHostEnvironment|IWebHostEnvironment|
|httpContextAccessor|IHttpContextAccessor|
## 
#### ValidateModel<M>(M model)

Global model validation method (View found in HomeSite.ClassLibrary.Razor)

|Parameters| |
| - | - |
|model|Model|

#### Returns:
KeyValuePair<int, string> 
## 
#### Error(System.Int32)

Global error handling

|Parameters| |
| - | - |
|id|int|

#### Returns:
IActionResult 
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Fillters.ControllerActionLogFilter'></a>

## HomeSite.ClassLibrary.Web.Mvc.Fillters.ControllerActionLogFilter
Action logging filter that runs before and after action method execution

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### ControllerActionLogFilter(ILogger<ControllerActionLogFilter> logger, IHttpContextAccessor httpContextAccessor)

Initializes a new instance
## 
#### OnActionExecuting(ActionExecutingContext context)

Executes before action method execution

|Parameters| |
| - | - |
|context|ActionExecutingContext|
## 
#### OnActionExecuted(ActionExecutedContext context)

Executes after action method execution

|Parameters| |
| - | - |
|context|ActionExecutedContext|
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Fillters.ControllerActionPageFilter'></a>

## HomeSite.ClassLibrary.Web.Mvc.Fillters.ControllerActionPageFilter
Action user filter that runs before and after action method execution

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### ControllerActionPageFilter(ILogger<ControllerActionPageFilter> logger, IHttpContextAccessor httpContextAccessor)

Initializes a new instance
## 
#### OnActionExecuting(ActionExecutingContext context)

Executes before action method execution

|Parameters| |
| - | - |
|context|ActionExecutingContext|
## 
#### OnActionExecuted(ActionExecutedContext context)

Executes after action method execution

|Parameters| |
| - | - |
|context|ActionExecutedContext|
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Fillters.ControllerActionUserFilter'></a>

## HomeSite.ClassLibrary.Web.Mvc.Fillters.ControllerActionUserFilter
Action user filter that runs before and after action method execution

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/17/2020 | Initial build |


### Methods:
#### ControllerActionUserFilter()

Initializes a new instance
## 
#### OnActionExecuting(ActionExecutingContext context)

Executes before action method execution

|Parameters| |
| - | - |
|context|ActionExecutingContext|
## 
#### OnActionExecuted(ActionExecutedContext context)

Executes after action method execution

|Parameters| |
| - | - |
|context|ActionExecutedContext|
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Models.ErrorViewModel'></a>

## HomeSite.ClassLibrary.Web.Mvc.Models.ErrorViewModel
Error view model

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/17/2020 | Initial build |


|Properties| |
| - | - |
|StatusCode|int|
|StatusMessage|string|
|Exception|Exception|
|RequestId|string|

### Methods:
#### ErrorViewModel(int statusCode)

Constructor method

|Parameters| |
| - | - |
|statusCode|int|
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Models.PageViewModel'></a>

## HomeSite.ClassLibrary.Web.Mvc.Models.PageViewModel
Page view model

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


|Properties| |
| - | - |
|ReturnURL|string|
|RequestId|string|
|ErrorMessage|string|
|ShowRequestId|bool|
|IsError|bool|
|Controller|string|
|Action|string|


( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Mvc.Models.UserViewModel'></a>

## HomeSite.ClassLibrary.Web.Mvc.Models.UserViewModel
User view model

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


|Properties| |
| - | - |
|IsAuthenticated|string|
|Id|string|
|Name|string|
|Email|string|
|Roles|List<string>|
|IPAddress|IPAddress|


( [Home](Home) )


<a name='HomeSite.ClassLibrary.Web.Security.AESGCM'></a>

## HomeSite.ClassLibrary.Web.Security.AESGCM
This work (Modern Encryption of a String C#, by James Tuley), identified by James Tuley, is free of known copyright restrictions. <br />https://gist.github.com/4336842 <br />http://creativecommons.org/publicdomain/mark/1.0/

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


|Fields| |
| - | - |
|NonceBitSize|int|
|MacBitSize|int|
|KeyBitSize|int|
|SaltBitSize|int|
|Iterations|int|
|MinPasswordLength|int|

### Methods:
#### NewKey

Helper that generates a random new key on each call.

#### Returns:
byte[] 
## 
#### SimpleEncrypt(System.String,System.Byte[],System.Byte[])

Simple Encryption And Authentication (AES-GCM) of a UTF8 string.

|Parameters| |
| - | - |
|secretMessage|The secret message.|
|key|The key.|
|nonSecretPayload|Optional non-secret payload.|

#### Returns:
Encrypted Message 

#### Exceptions:
System.ArgumentException ( Secret Message Required!;secretMessage )
## 
#### SimpleDecrypt(System.String,System.Byte[],System.Int32)

Simple Decryption and Authentication (AES-GCM) of a UTF8 Message

|Parameters| |
| - | - |
|encryptedMessage|The encrypted message.|
|key|The key.|
|nonSecretPayloadLength|Length of the optional non-secret payload.|

#### Returns:
Decrypted Message 
## 
#### SimpleEncryptWithPassword(System.String,System.String,System.Byte[])

Simple Encryption And Authentication (AES-GCM) of a UTF8 String using key derived from a supplied password (PBKDF2).

|Parameters| |
| - | - |
|secretMessage|The secret message.|
|password|The password.|
|nonSecretPayload|The non secret payload.|

#### Returns:
Encrypted Message 
## 
#### SimpleDecryptWithPassword(System.String,System.String,System.Int32)

Simple Decryption and Authentication (AES-GCM) of a UTF8 message using a key derived from a supplied password (PBKDF2)

|Parameters| |
| - | - |
|encryptedMessage|The encrypted message.|
|password|The password.|
|nonSecretPayloadLength|Length of the non secret payload.|

#### Returns:
Decrypted Message 

#### Exceptions:
System.ArgumentException ( Encrypted Message Required!;encryptedMessage )
## 
#### SimpleEncrypt(System.Byte[],System.Byte[],System.Byte[])

Simple Encryption And Authentication (AES-GCM) of a UTF8 String using key derived from a default internal password (PBKDF2).

|Parameters| |
| - | - |
|secretMessage|byte[]|
|key|byte[]|
|nonSecretPayload|byte[]|

#### Returns:
Encrypted Message 
## 
#### SimpleDecrypt(System.Byte[],System.Byte[],System.Int32)

Simple Decryption and Authentication (AES-GCM) of a UTF8 message using a key derived from a default internal password (PBKDF2)

|Parameters| |
| - | - |
|encryptedMessage|byte[]|
|key|byte[]|
|nonSecretPayloadLength|int|

#### Returns:
Decrypted Message 

#### Exceptions:
System.ArgumentException ( Encrypted Message Required!;encryptedMessage )
## 
#### SimpleEncryptWithPassword(System.Byte[],System.String,System.Byte[])

Simple Encryption With Password

|Parameters| |
| - | - |
|secretMessage|byte[]|
|password|string|
|nonSecretPayload|byte[]|

#### Returns:
byte[] 
## 
#### SimpleDecryptWithPassword(System.Byte[],System.String,System.Int32)

Simple Decryption With Password

|Parameters| |
| - | - |
|encryptedMessage|byte[]|
|password|string|
|nonSecretPayloadLength|int|

#### Returns:
 
## 
#### Encrypt(string plainText)

Method to encrypt plain text string

|Parameters| |
| - | - |
|plainText|string|

#### Returns:
string 
## 
#### Decrypt(string encryptedText)

Method to decrypt encrypted string to plain text

|Parameters| |
| - | - |
|encryptedText|string|

#### Returns:
string 
## 

( [Home](Home) )

