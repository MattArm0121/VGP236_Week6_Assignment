Today in class, we were tasked with creating a basic shooter setup. Having the gun rotate to follow our mouse, and when it hovered over a target, to have a pop-up button that, when clicked, would destroy the target. We were also introduced to the Unity Asset Store, which is where the gun and target model came from.

My greatest difficulty with this assignment was figuring out how to make the scope line appear. Following the gun to your mouse position. We were taught the Debug.DrawLine, but that only causes the line to appear in Scene view, not Game view. I did not think that worked well in the game. So, I researched how to create a sight line. There, I found the LineRenderer component.

It took me a while to figure out how to get it set up, especially to follow the gun's rotation. But I now feel confident that I can have a clear line indicating where a player is aiming in a gun game. 

Once that was done, the rest of the requirements were easy for me to accomplish. Raycasting to a collider which was on the targets made it easy to destroy them on a button click.

Overall, this assignment had its challenges, but I am glad I was able to learn how LineRenderer worked. Such as changing its start and end using the graph it has in the component.

Below is an example of the finalized assignment. Building upon this, I would make the ground grass with the background being trees. I'd also change the gun to a bow. That way, it looks as if you are in the forest at an archery range. Perhaps I could make the targets animals, and depending on position, it would change to a bird or a deer. There is a lot I can expand upon this in the future.

<img width="1238" height="688" alt="TargetGameExample" src="https://github.com/user-attachments/assets/1ab8b19a-edf6-4fce-b54d-80e1f236ced4" />
