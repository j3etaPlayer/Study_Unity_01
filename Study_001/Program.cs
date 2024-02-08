/* 데이터 타입
 * 데이터 타입은 기본타입과 참조타입이 있다.
 * 기본타입은 데이터의 크기가 작은 int, char, double, float 등등.. 이 있고
 * 참조타입은 데이터의 크기가 큰 string, class 등이 있다.
 */

/* C#의 데이터 영역
 * 코드, 데이터, 힙, 스택이 있다.
 */

/* C#의 특징
 * C#은 힙영역을 자동으로 관리해준다.
 * 관리되는 힙을 Managed Heep이라고 부르며
 * 이힙은 GC가 관리한다.
 */

/* C++와 C#의 차이
 * C++  : Delete 키워드로 메모리를 해제해주어야 한다.
 * C#   : GC(GarbageCollector)가 Garbage Collection을 하여 메모리를 자동으로 해제해준다.
 */

/* GC(GarbageCollector)
 * 참조할 수 없는 힙에 할당된 데이터를 자동으로 관리해준다.
 * GC는 스택이나 힙영역에서 다른 힙영역에 있는 쓰레기 값이
 * 일정수준 쌓이면 힙에있는 데이터를 삭제하고 빈공간을 정렬한다.
 * 
 * GC는 1세대부터 3세대까지 있는데 각 세대별로 Garbege Collection이 일어난다.
 * 그런데 3세대 Garbege Collection이 일어날때 프로세스를 잠시 멈추고 정리를 한다.
 */

/* 네임스페이스
 * A개발자와 B개발자
 */

var a = 3;
var b = "안녕";

object aa = 3;
object bb = "안녕";

Console.WriteLine($"{a} {b} {aa} {bb}");

/* boxing과 unboxing
 * boxing은 데이터 타입에서 "기본타입"을 "참조타입"으로 바꾸는 것을 말하고
 * unboxing은 "참조타입"을 "기본타입"으로 바꾸는것을 말한다.
 */

/* var와 object의 차이
 * var은 컴파일러가 가장 가까운 데이터 타입으로 형식을 지정해주지만
 * object는 기본타입을 참조타입으로 박싱을 한다.
 */