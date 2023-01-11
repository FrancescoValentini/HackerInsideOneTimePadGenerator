# HackerInside One Time Pad Generator
Generatore di One Time Pad

![MainScreen](https://github.com/FrancescoValentini/HackerInsideOneTimePadGenerator/blob/master/mainScreen.JPG)
## Sicurezza del software
Questo applicativo utilizza la classe RNGCryptoServiceProvider per funzionare, 
un cifrario One Time Pad è realmente sicuro solo se le chiavi utilizzate sono random al 100%

Inoltre generare le chiavi per un cifrario One Time Pad su un computer di uso comune e connesso ad internet è estremamente pericoloso, qualora fosse necessario l'utilizzo di un qualsiasi sistema One Time Pad in produzione è consigliato dotarsi di un metodo affidabile e sicuro per generare le chiavi (es. RNG hardware).

## Formati supportati
  - **Lettere:** impostazione predefinita del software, genera chiavi composte solo da lettere maiuscole A-Z
  - **Numeri:** genera chiavi composte solo da numeri 0-9
  - **Hex:** Genera chiavi composte da numeri esadecimali 0x0-0xF
  - **KTC1400C:** DRYAD Numeral Cipher/Authentication System (versione pensata per l'utilizzo con dispositivo KAL 61 https://commons.wikimedia.org/wiki/File:Encryption_sheet_holder.jpg)
  - **KTC1400D:** DRYAD Numeral Cipher/Authentication System (Versione utilizzabile solamente con carta e penna)
  - **AUTH TABLE:** Sistema pensato per autenticare una trasmissione (tipicamente utilizzato quando non è possibile utilizzare autenticazioni di tipo challenge-response)
  - **VLOTP:** Sistema da me ideato (NON CONSIDERABILE SICURO) per criptare brevi stringhe o autenticare messaggi (basato su KTC1400D)
  
## Disclaimer
Questo software è a puro scopo di divertimento, non deve essere preso in considerazione come punto di riferimento.

Non mi assumo nessuna responsabilità di eventuali danni provocati da questo codice o da suoi possibili usi impropri.

## Credits
<a href="https://www.flaticon.com/free-icons/spy" title="spy icons">Spy icons created by Freepik - Flaticon</a>

## Sitografia
- https://en.wikipedia.org/wiki/DRYAD
- https://goto.pachanka.org/crypto/dryad-pad/
- https://www.globalsecurity.org/military/library/policy/army/accp/ss0002/le3.htm
