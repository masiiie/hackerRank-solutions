function maximumWealth(accounts: number[][]): number {
    let maxWealth = 0;
    for(let i=0; i<accounts.length;i++){
        let sum = 0;
        for(let j=0;j<accounts[0].length;j++) sum+=accounts[i][j];
        maxWealth = Math.max(sum, maxWealth);
    }
    return maxWealth;
};