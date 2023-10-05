################################################3
# # 사전 (연관 배열) - 리스트 두개(key, value)를 연관시킨다.
# # - 키와 값의 쌍을 저장하는 대용량의 자료 구조
# # . 해시 알고리즘 (키에 맞는 값의 주소를 일정한 규칙에 의해 연결하는 함수)을 총하여
# #   데이터가 등록되고 관리
# # . 해시 함수의 의존도가 높고, 공간복잡도(메모리손실비용)가 증가한다
# # . 리스트에 비해 검색속도가 빠르다(시간 복잠도가 감소)
# # . 리스트는 선행 탐색 구조(처음부터 순차적으로 데이터를 확인)
# # - 키
# #   . 값을 찾는 기준
# #   . 중복되지 않는 고유한 값을 가진다.
# #   . 읽기 전용 속성 변경 할 수 없다.
# # - 값
# #   . 키에 할당 되는 데이터
# #   . 데이터 변경이 가능하다.


# # 사전 포멧 { }
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'} 
# print(dic) # 사전 자료형 구조는 곧바로 호출해서 사용 할  수 있다.
# print(dic['boy']) # 해당 키에 등록된 값을 확인할 수 있다.


####################dictionary의 메서드################################
# # get() : Key로 값을 찾음. 없으면 none을 반환(null)

# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'} 
# print(dic.get('boy')) 
# print(dic.get('boys')) # 시스템 오류를 반환하지 않는다. (값을 유동적으로 찾기에 용이)
# print(dic['boys']) # 시스템 오류가 발생한다.

# # in을 통한 사전 데이터의 검색
# # in은 key의 데이터를 확인 할 수 있다.
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'} 
# if 'boys' in dic :
#     print("1. 데이터가 있습니다.", dic['boys'])
# elif 'boy' in dic :
#     print("2. 데이터가 있습니다. : ", dic['boy'])

# # 사전의 데이터 수정, 추가, 삭제
# # 키가 있으면 update, 없으면 insert 갱신에 오류가 날 확률이 매우 적다.
# # 시스템 오류가 발생 될 가능성은 낮지만, 오타등의 이유로 데이터의 변질이 일어날 확률이 높다.
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# dic['boy'] = '남자아이'
# print(dic['boy'])

# dic['girl'] = '여자'
# print(dic)

# del dic['boy'] # 키와 값 데이터가 동시에 배치
# print(dic)

# # Key와 Value를 목록으로 만들어 확인하기
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'} 
# print(dic.keys())
# print(dic.values())
# print(dic.items())

# # Key 추출하여 출력
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'} 
# keylist = dic.keys()
# keylist = dic.values()
# for key in keylist : 
#     print(key)

# # # 사전간 결합 update()
# # # 두 사전의 'book' 키가 중복되면 뒤따르는 사전에 있는 데이터가 update
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'} 
# dic2 = {'girl' : '여자', 'dept' : '회사', 'book' : '서적'} 
# dic.update(dic2) # dic1에 dic2 사전의 데이터를 덧붙인다. 
#                  # 중복은 허용 X 중복데이터는 후위 사전데이터로 update
# print(dic) 

# # 2차원 리스트, 튜플의 사전변환
# # 다른 자료형 구조를 사전으로 변화,  key와 value 쌍으로 구성되어있으면 사전형태로 변환이 가능

# li = [['boy', '소년'], ['book', '책']]
# dic = dict(li)
# print(type(dic),dic)

# tu = (('boy', '소년'), ('book', '책'))
# dic = dict(tu)
# print(type(dic),dic)

# joson 형식 dic 형식(객체 자료형)이라서 호환성이 높다.

song = '''
Like an apple is my face
(사과 같은 내 얼굴)
How I look so beautiful
(예쁘기도 하구나)
Eyes are shiny nose is shiny
(눈도 반짝 코도 반짝)
And my lips are shiny
(입도 반짝 반짝 )
''' 

# # 사전으로 등록해둔 데이터를 순차적으로 정렬해서 표현하는 방법.
# # For를 사용

dicword = dict()
for w in song :
    if w.isalpha() == False :
        continue
    w = w.lower()
    if w not in dicword :
        dicword[w] = 1
    else :  
        dicword[w] += 1
keylist = list(dicword.keys()) # 사전의 키를 추출해서 list로 형변환후 리스트 자요형에 할당
keylist.sort() # 키가 담긴 리스트를 오름차순으로 정렬 a,b,c,d,e ......
for w in keylist : # 키가 오름차순으로 정렬된 리스트에서 
    print(w, '=>', dicword[w])
# dicword.get(word, 0) : word로 된 키가 있으면 그 값을 반환 없으면 0을 반환

for codvalue in range(ord('a'), ord('z') + 1 ) :
    word = chr(codvalue) # 아스키 코드 값을 문자로 변형 후 word 변수에 할당
    print(word, '=>', dicword.get(word))

song = song.lower()

char_count = {}

# 문자열을 한 글자씩 순회하면서 빈도를 계산
for char in song:
    if char.isalpha():
        if char in char_count:
            char_count[char] += 1
        else:
            char_count[char] = 1

# 빈도가 가장 높은 문자와 그 빈도를 찾기
max_count = max(char_count.values())
most_common_chars = [(char, count) for char, count in char_count.items() if count == max_count]

# 결과 출력
print(dict(most_common_chars))
