﻿'''<Summary>The PaymentCurrencyAmount dictionary describes an amount of money in terms of both a number of units and the currency (US dollars, Euro, yen, etc.), and is part of the Payment Request API.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [PaymentCurrencyAmount]
  '''<Summary>A string containing a valid 3-letter ISO 4217 currency identifier (ISO 4217) indicating the currency used for the payment value.</Summary>
  Property [currency] As String
  '''<Summary>A string containing a valid decimal value representing the mount of currency constituting the payment amount. This string must only contain an optional leading "-" to indicate a negative value, then one or more digits from 0 to 9, and an optional decimal point (".", regardless of locale) followed by at least one more digit. No whitespace is permitted.</Summary>
  Property [value] As String
End Interface