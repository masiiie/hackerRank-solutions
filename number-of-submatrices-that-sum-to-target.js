var numSubmatrixSumTarget = function(matrix, target) {
    const prefixSums = new Array(matrix.length + 1)
        .fill()
        .map(() => new Array(matrix[0].length + 1).fill(0));
    
    for (let i = 1; i <= matrix.length; i++) {
        for (let j = 1; j <= matrix[0].length; j++) {
            prefixSums[i][j] = matrix[i-1][j-1] + prefixSums[i-1][j] + prefixSums[i][j-1] - prefixSums[i-1][j-1];
        }
    }
    
    let count = 0;
    for (let r1 = 1; r1 <= matrix.length; r1++) {
        for (let r2 = r1; r2 <= matrix.length; r2++) {
            const counts = {};
            counts[0] = 1;
            for (let c = 1; c <= matrix[0].length; c++) {
                const sum = prefixSums[r2][c] - prefixSums[r1 - 1][c];
                count += counts[sum - target] || 0;
                counts[sum] = (counts[sum] || 0) + 1;
            }
        }
    }
    
    return count;
};