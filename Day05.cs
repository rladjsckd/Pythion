######################################
# # 튜플
# # 값이 한번 초기화 된 후 임의의 데이터를 할당 할 수 없는 자료구조(자료집합, 상수)
# # . 값의 변경을 하고 재배치하는 프로세스의 메모리를 소비하지 않으므로 리스트보다는 가볍다.
# # . 데이터가 변질되면 안되는 경우. 상수 형태의 튜플로 작성해 두면 오류를 방지 하 수 있다.
######################################

# # 튜플의 선선
# score = 10,20,30,40,50
# print(tuple(score), score)

# score = (10,20,30,40,50) # 튜플은 ( )을 통하여 선언 하는것이 개발자 국룰
# print(tuple(score), score)

# # 함수 (메서드)의 반환 결과 : 튜플
# def DoSomething() :
#     return '첫번째 반환값','튜플', 100, True
# result = DoSomething()

# # result[0] = 'aaa' 튜플로 전달 받은 값은 변경할 수 없다.
# print(result)

 # # 함수 결과 반환 두번째
# def DoSomething() :
#     return '첫번째 반환값','튜플', 100, True

# re1, re2, re3, re4 = DoSomething()
# print(type(re1), re1)
# print(type(re2), re2)
# print(type(re3), re3)
# print(type(re4), re4)
