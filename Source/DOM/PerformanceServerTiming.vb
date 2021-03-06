﻿'''<Summary>The PerformanceServerTiming interface surfaces server metrics that are sent with the response in the Server-Timing HTTP header.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [PerformanceServerTiming]
  '''<Summary>A DOMString value of the server-specified metric description, or an empty string.</Summary>
  ReadOnly Property [description] As String
  '''<Summary>A double that contains the server-specified metric duration, or value 0.0.</Summary>
  ReadOnly Property [duration] As Double
  '''<Summary>A DOMString value of the server-specified metric name.</Summary>
  ReadOnly Property [name] As String
End Interface