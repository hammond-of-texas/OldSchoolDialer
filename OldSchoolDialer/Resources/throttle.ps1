# Sets a new QOS policy that throttles the internet speed to 128 KBits/s

New-NetQosPolicy -name "Throttle" -ThrottleRateActionBitsPerSecond 128KB -PolicyStore ActiveStore
gpupdate /force