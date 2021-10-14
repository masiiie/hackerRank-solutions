import math
import os
import random
import re
import sys

#
# Complete the 'miniMaxSum' function below.
#
# The function accepts INTEGER_ARRAY arr as parameter.
#

def miniMaxSum(arr):
    _sum = sum(arr)
    maxsum = _sum - min(arr)
    minsum = _sum - max(arr)
    print("{0} {1}".format(minsum, maxsum))

if __name__ == '__main__':

    arr = list(map(int, input().rstrip().split()))

    miniMaxSum(arr)