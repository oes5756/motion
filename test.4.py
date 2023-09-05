from IPython.display import display, HTML
display(HTML("<style>.container { width:100% !important; }</style>"))#추출열 최대화
import cv2
import sys
import numpy as np
np.set_printoptions(threshold=sys.maxsize)

#불러올 이미지 파일의 경로
imageFile = 'etc/test.jpg'  #해당출처의 이미지 파일을 사용 
src = cv2.imread(imageFile, 0)  # 해당파일은 흑백로 전환

#이미지를 불러옵니다.
imgArray = cv2.imread(imageFile, 0) #cv2.imread(imageFile, cv2.IMREAD_GRAYSCALE)
cv2.imwrite('etc/sample.jpg',0  # etc 위치에 sample 파일 생성 
cv2.imshow('sample',src)  # 윈도우창 출력 

print(imgArray)  # 출력값으로 아래 출력

cv2.waitKey(0)    # 키보드 키입력 대기
cv2.destroyAllWindows() # 키입력시 윈도우 창 해제
