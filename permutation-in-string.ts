function checkInclusion(s1: string, s2: string): boolean {
    let i = 0;
    let map = new Map<string, number>();
    let match = 0;
    for(let j=0; j<s2.length; j++){
        if(s1.includes(s2[j])){
            match++;
            if(match==s1.length) return true;
        }
        else{
            match = 0;
        }
    }

    return false;
};


let s1 = 'amadecasam';
let map = new Array<number>(26);
for (let i = 0; i < s1.length; i++) {
    map[s1[i] - 'a']++;
}