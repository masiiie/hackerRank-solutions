/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {number}
 */
 var numSubmatrixSumTarget = function(matrix, target) {
    let hashTable = {}; 
    let noSub = 0;

    var funAux = function(x1, x2, y1, y2){
        if(x1 == x2 && y1 == y2) if(matrix[x1][y1] == target) noSub++
        else if(x1 > x2 || y1 > y2 || x1 < 0 || y1 < 0 || x2 > matrix.length -1 || y2 > matrix[0].length -1) return;
        else if((x1, x2, y1, y2) in hashTable) return;
        else{
            funAux(x1 + 1, x2, y1, y2);
            funAux(x1 + 1, x2 + 1, y1 + 1, y2);
            funAux(x1 + 1, x2 + 1, y1 + 1, y2 + 1);
            funAux(x1 + 1, x2 + 1, y1 + 1, y2 + 1);
            funAux(x1 + 1, x2 + 1, y1, y2);

            let tuple = [x1, x2, y1, y2];

            for (let i = 0; i < 4; i++) {
                
            }
        }
    };

    funAux(0, matrix.length-1, 0, matrix[0].length - 1);
    return noSub;
};