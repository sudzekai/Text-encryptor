# Text encryptor
Мой первый проект по шифровке и дешфровке строк
## Алгоритм
Одна буква = два символа. Функция сравнит каждую букву этой строки с существующим в массиве символов, которые могут быть зашифрованы, символом и, в случае, если буква и символ совпадают, метод сгенерирует случайное число, которое не может быть меньше, чем положение этой буквы в массиве символов. Первый символ - разница в расположении буквы и рандомного символа в массиве, второй символ - рандомный символ.

Таким образом, каждая новая строка, идентичная предыдущей, будет зашифрована одним способом, но выход будет разный. 

Возьмем любую строку, например: **Первый шифр**.
```
Первый шифр.
Encrypted: lOэLЪ5<M<SlчЭOО}C7шЬМv
Decrypted: Первый шифр
Первый шифр.
Encrypted: <bд :%-л- ojЪ7ГёQeЯLQВ
Decrypted: Первый шифр
Первый шифр
Encrypted: Фh*sgёdвm.RЖо|G1АпФЦrР
Decrypted: Первый шифр
```
Стоит отметить, что даже повторяющиеся в строке буквы, шифруются разными символами и единственный способ расшифровать всё это - массив символов.
## Уязвимости
На данный момент я нашел лишь одну уязвимость - последний символ в массиве. Так как случайное число не может быть меньше номера положения буквы, последний символ массива всегда будет зашифрован одним и тем же образом, что значит, чем дальше от конца находится буква, тем большим количеством способов она может быть зашифрована.

