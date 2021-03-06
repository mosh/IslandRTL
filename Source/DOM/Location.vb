﻿'''<Summary>The Location interface represents the location (URL) of the object it is linked to. Changes done on it are reflected on the object it relates to. Both the Document and Window interface have such a linked Location, accessible via Document.location and Window.location respectively.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [Location]
  '''<Summary>Is a static DOMStringList containing, in reverse order, the origins of all ancestor browsing contexts of the document associated with the given Location object.</Summary>
  Property [ancestorOrigins] As String
  '''<Summary>Is a stringifier that returns a USVString containing the entire URL. If changed, the associated document navigates to the new page. It can be set from a different origin than the associated document.</Summary>
  Property [href] As String
  '''<Summary>Is a USVString containing the protocol scheme of the URL, including the final ':'.</Summary>
  Property [protocol] As String
  '''<Summary>Is a USVString containing the host, that is the hostname, a ':', and the port of the URL.</Summary>
  Property [host] As String
  '''<Summary>Is a USVString containing the domain of the URL.</Summary>
  Property [hostname] As String
  '''<Summary>Is a USVString containing the port number of the URL.</Summary>
  Property [port] As String
  '''<Summary>Is a USVString containing an initial '/' followed by the path of the URL.</Summary>
  Property [pathname] As String
  '''<Summary>Is a USVString containing a '?' followed by the parameters or "querystring" of the URL. Modern browsers provide URLSearchParams and URL.searchParams to make it easy to parse out the parameters from the querystring.</Summary>
  Property [search] As String
  '''<Summary>Is a USVString containing a '#' followed by the fragment identifier of the URL.</Summary>
  Property [hash] As String
  '''<Summary>Returns a USVString containing the canonical form of the origin of the specific location.</Summary>
  ReadOnly Property [origin] As String
End Interface