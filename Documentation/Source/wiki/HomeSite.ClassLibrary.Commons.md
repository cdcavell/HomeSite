
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


<a name='HomeSite.ClassLibrary.Commons.Logging.ConsoleLog'></a>

## HomeSite.ClassLibrary.Commons.Logging.ConsoleLog
Static console logging class.

__Revisions:__

| Contributor | Build | Revison Date | Description |
|-------------|-------|--------------|-------------|
| Christopher D. Cavell | 0.0.1 | 05/15/2020 | Initial build |


### Methods:
#### Exception(Exception exception)

Method to write formated exception information to console

|Parameters| |
| - | - |
|exception|Exception|
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

