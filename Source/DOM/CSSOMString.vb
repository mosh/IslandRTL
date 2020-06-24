﻿'''<Summary>CSSOMString is used to denote string data in CSSOM specifications and can refer to either DOMString or USVString. When a specification says CSSOMString, it depends on the browser vendors to choose whether to use DOMString or USVString. While browser implementations that use UTF-8 internally to represent strings in memory can use USVString when the specification says CSSOMString, implementations that already represent strings as 16-bit sequences might choose to use DOMString instead.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [CSSOMString]
'Defined on this type 
End Interface