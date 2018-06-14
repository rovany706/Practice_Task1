# Бутылки - 2
[Ссылка на задачу](https://acmp.ru/index.asp?main=task&id_task=450)

В цех вторичной переработки поступают бутылки N видов: A, B, C, … (первые N заглавных букв английского алфавита). Бутылки поступают на переработку партиями из N контейнеров, причем в каждом контейнере могут находиться бутылки различных видов. Перед вторичной переработкой бутылок специальные рабочие сортируют их по видам таким образом, чтобы после сортировки в каждом из поступивших контейнеров остались бутылки только одного вида. В каждом из контейнеров может помещаться неограниченное количество бутылок.

Требуется написать программу, которая определяет минимальное количество перемещений бутылок, обеспечивающих их сортировку по видам, причем за каждое перемещение можно переместить только одну бутылку из одного контейнера в другой. 

## Входные данные
Входной файл INPUT.TXT состоит из N+1 строк. В первой строке записано число N (1≤N≤8). Во второй строке располагаются разделенные пробелами N целых числа, соответствующие количеству бутылок вида A, B, C, … в первом контейнере. В последующих строках содержится аналогичная информация для второго, третьего, …, N-го контейнеров соответственно. Известно, что количество бутылок в каждом из контейнеров не превосходит 32767.

## Выходные данные
Выходной файл OUTPUT.TXT должен состоять из двух строк. В первой располагается последовательность из символов A, B, C, …, которая определяет какого вида бутылки находятся после сортировки в 1-м, 2-м, …, N-м контейнерах. Во второй строке располагается число, определяющее искомое количество перемещений бутылок. Если возможно несколько вариантов ответа, то необходимо выдать любой из них. 