
<a name='HomeSite.ClassLibrary.Commons.AsciiCodes'></a>

## HomeSite.ClassLibrary.Commons.AsciiCodes
Static class for converting ascii decimal value to string equivalent.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/14/2020 | Initial build |


|Fields| |
| - | - |
|NUL|(null)|
|SOH|(start of heading)|
|STX|(start of text)|
|ETX|(end of text)|
|EOT|(end of transmission)|
|ENQ|(enquiry)|
|ACK|(acknowledge)|
|BEL|(bell)|
|BS|(backspace)|
|TAB|(horizontal tab)|
|LF|(NL line feed, new line)|
|VT|(vertical tab)|
|FF|(NP form feed, new page)|
|CR|(carriage return)|
|SO|(shift out)|
|SI|(shift in)|
|DLE|(data link escape)|
|DC1|(device control 1)|
|DC2|(device control 2)|
|DC3|(device control 3)|
|DC4|(device control 4)|
|NAK|(negative acknowledge)|
|SYN|(synchronous idle)|
|ETB|(end of trans. block)|
|CAN|(cancel)|
|EM|(end of medium)|
|SUB|(substitute)|
|ESC|(escape)|
|FS|(file separator)|
|GS|(group separator)|
|RS|(record separator)|
|US|(unit separator)|
|CRLF|(carriage return) + (NL line feed, new line)|

### Methods:
#### ToString(int dec)

Method to return string value of given ascii decimal

|Parameters| |
| - | - |
|dec|int|

#### Returns:
string 
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Commons.Logging.Logger'></a>

## HomeSite.ClassLibrary.Commons.Logging.Logger
Global application logger

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### Logger(ILogger logger)

Initialize logger class

|Parameters| |
| - | - |
|logger|ILogger|
## 
#### Information(string message)

Information logging

|Parameters| |
| - | - |
|message|string|
## 
#### Debug(string message)

Debug logging

|Parameters| |
| - | - |
|message|string|
## 
#### Debug(string message)

Debug logging

|Parameters| |
| - | - |
|message|string|
## 
#### Warning(string message)

Warning logging

|Parameters| |
| - | - |
|message|string|
## 
#### Critical(Exception exception, string message)

Warning logging

|Parameters| |
| - | - |
|exception|Exception|
|message|string|
## 
#### Exception(Exception exception, string message = null)

Exception logging

|Parameters| |
| - | - |
|exception|Exception|
|message|string|
## 
#### Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)

Implementation of ILogger method

|Parameters| |
| - | - |
|logLevel|LogLevel|
|eventId|EventId|
|state|TState|
|exception|Exception|
|formatter|Func<TState, Exception, string>|
## 
#### IsEnabled(LogLevel logLevel)

Implementation of ILogger method

|Parameters| |
| - | - |
|logLevel|LogLevel|

#### Returns:
bool 
## 
#### BeginScope<TState>(TState state)

Implementation of ILogger method

|Parameters| |
| - | - |
|state|TState|

#### Returns:
IDisposable 
## 

( [Home](Home) )


<a name='HomeSite.ClassLibrary.Commons.Xml.Transform'></a>

## HomeSite.ClassLibrary.Commons.Xml.Transform
Class to perform XSLT Transformation

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/14/2020 | Initial build |


### Methods:
#### Write(string inputXslt, string inputXml, string outputFile)

Method to perform XSLT Transformation and write out file

|Parameters| |
| - | - |
|inputXslt|string|
|inputXml|string|
|outputFile|string|
## 

( [Home](Home) )


<a name='System.Linq.EnumerableExtentions'></a>

## System.Linq.EnumerableExtentions
Extension methods for existing Enumerable types.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |


### Methods:
#### DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)

Method to determine if string is a valid email address

|Parameters| |
| - | - |
|source|this IEnumerable<TSource>|
|keySelector|Func<TSource, TKey>|

#### Returns:
IEnumerable<TSource> 
## 

( [Home](Home) )


<a name='System.StringExtensions'></a>

## System.StringExtensions
Extension methods for existing string types.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/15/2020 | Initial build |


### Methods:
#### IsValidEmail(this string email)

Method to determine if string is a valid email address

|Parameters| |
| - | - |
|email|this string|

#### Returns:
bool 
## 
#### string Clean(this string value)

Method to remove "Carriage Return" and "Line Feed" as well as Html filtering to provide proper neutralization.

|Parameters| |
| - | - |
|value|this string|

#### Returns:
string 
## 

( [Home](Home) )

