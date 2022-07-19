class TreeAncestor:

    def __init__(self, n: int, parent: List[int]):
        self.LOG = int(math.log2(n)) + 1
        self.dp = [[0 for i in range(self.LOG)] for j in range(n)]
        
        for i in range(0, n):
            self.dp[i][0] = parent[i]
        
        for i in range(0, n):
            for j in range(1, self.LOG):
                if self.dp[i][j-1] != -1:
                    self.dp[i][j] = self.dp[self.dp[i][j-1]][j-1]
                else:
                     self.dp[i][j] = -1

    def getKthAncestor(self, node: int, k: int) -> int:
        i = 0
        while i < self.LOG and node != -1:
            if k & (1 << i):
                node = self.dp[node][i]
            i+=1
        return node