// JavaScript source code
let check = document.getElementById("check");
check.innerHTML = "Hello DOM";
console.log(check.outerHTML);

//append(element);      //��������� ������� � ����� ����, � ������ ����� ������������
//prepend(element);     //��������� ������� � ������ ����, � ������ ,����� ������������ �����������
//before(element);      //��������� ������� ����� ����������� ������������
//after(element);      //��������� ������� ����� ����������� ������������

//Node - ��� ���� ������.

let configuration = document.getElementById("configuration");
configuration.append("append();");
configuration.prepend("prepend();");
configuration.before("before();");
configuration.after("after();");