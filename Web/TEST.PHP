<?php

if($a==""){
    $a=100;
}

if($b==""){
    $b=100;
}

echo "您的視力".$a.$b."<br>狀況：";

if($a>=100&$b>=100){
    echo"近視";
}elseif($a=100&$b=100){
    echo"輕度近視";
}elseif($a<=100&$b<=100){
    echo"假近視";
}else{
    echo"正常";
}
?>
