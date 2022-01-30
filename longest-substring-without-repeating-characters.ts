function lengthOfLongestSubstring(s: string): number {
    let i = 0;
    let solution = 0;
    let map = new Map<string, number>();
    for (let j = 0; j < s.length; j++) {
        if(map.has(s[j])) i = Math.max(map.get(s[j])+1, i);
        map.set(s[j], j);
        solution = Math.max(solution, j-i+1);
    }
    return solution;
};