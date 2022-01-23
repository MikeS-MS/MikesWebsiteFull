(function() {
    let array = ["six", "innate", "volatile", "bouncy", "legal", "doubtful", "soft", "circle", "imaginary", "savory", "hard", "creature", "zephyr", "ducks", "way", "glistening", "flippant", "belief", "fasten", "talented", "sassy", "sweltering", "omniscient", "earsplitting", "arrest", "angle", "insurance", "trees", "stove", "thoughtful", "mindless", "bewildered", "beef", "odd", "file", "question", "machine", "tart", "telling", "three", "oil", "soggy", "yarn", "bashful", "bent", "towering", "unit", "royal", "neighborly", "raspy", "deserve", "fast", "industry", "men", "pets", "abhorrent", "tooth", "zebra", "lazy", "delirious", "greedy", "jellyfish", "ready", "fix", "pail", "volcano", "quick", "cheese", "smiling", "spot", "supreme", "cause", "gigantic", "teaching", "quartz", "chew", "angry", "obtainable", "aftermath", "vigorous", "prose", "extend", "knowledgeable", "scientific", "possess", "melodic", "jewel", "admit", "redundant", "vivacious", "agreement", "squeamish", "early", "black-and-white", "few", "scary", "rude", "water", "connect", "sticks"];
    let descriptions = ["Today I dressed my unicorn in preparation for the race.", "Thigh-high in the water, the fisherman’s hope for dinner soon turned to despair.", "He quietly entered the museum as the super bowl started.", "Everyone was curious about the large white blimp that appeared overnight.", "Even with the snow falling outside, she felt it appropriate to wear her bikini.", "It doesn't sound like that will ever be on my travel list.", "Hit me with your pet shark!", "The river stole the gods.", "She can live her life however she wants as long as she listens to what I have to say.", "Random words in front of other random words create a random sentence.", "So long and thanks for the fish.", "Everybody should read Chaucer to improve their everyday vocabulary.", "She felt that chill that makes the hairs on the back of your neck when he walked into the room.", "I would be delighted if the sea were full of cucumber juice.", "I may struggle with geography, but I'm sure I'm somewhere around here.", "Please wait outside of the house.", "She looked at the masterpiece hanging in the museum but all she could think is that her five-year-old could do better.", "He liked to play with words in the bathtub.", "Behind the window was a reflection that only instilled fear.", "The white water rafting trip was suddenly halted by the unexpected brick wall.", "He had concluded that pigs must be able to fly in Hog Heaven.", "It was always dangerous to drive with him since he insisted the safety cones were a slalom course.", "Gary didn't understand why Doug went upstairs to get one dollar bills when he invited him to go cow tipping.", "Chocolate covered crickets were his favorite snack.", "Thirty years later, she still thought it was okay to put the toilet paper roll under rather than over.", "The hummingbird's wings blurred while it eagerly sipped the sugar water from the feeder.", "The external scars tell only part of the story.", "Malls are great places to shop; I can find everything I need under one roof.", "She learned that water bottles are no longer just to hold liquid, but they're also status symbols.", "His mind was blown that there was nothing in space except space itself.", "They looked up at the sky and saw a million stars.", "You've been eyeing me all day and waiting for your move like a lion stalking a gazelle in a savannah.", "The skeleton had skeletons of his own in the closet.", "Excitement replaced fear until the final moment.", "Pat ordered a ghost pepper pie.", "Abstraction is often one floor above you.", "If any cop asks you where you were, just say you were visiting Kansas.", "She tilted her head back and let whip cream stream into her mouth while taking a bath.", "The door swung open to reveal pink giraffes and red elephants.", "She is never happy until she finds something to be unhappy about; then, she is overjoyed.", "On a scale from one to ten, what's your favorite flavor of random grammar?", "The rusty nail stood erect, angled at a 45-degree angle, just waiting for the perfect barefoot to come along.", "She used her own hair in the soup to give it more flavor.", "People who insist on picking their teeth with their elbows are so annoying!", "I caught my squirrel rustling through my gym bag.", "I often see the time 11:11 or 12:34 on clocks.", "She finally understood that grief was her love with no place for it to go.", "It had been sixteen days since the zombies first attacked.", "He poured rocks in the dungeon of his mind.", "When transplanting seedlings, candied teapots will make the task easier."];

    let container = document.getElementsByClassName('image-scroll')

    for (i = 1; i < 10; i++) {
        let title = array[Math.round(Math.random() * 99)]
        let description = descriptions[Math.round(Math.random() * 49)]

        var element = document.createElement('div')
        element.classList.add('picture-frame')
        element.innerHTML = `
        <a class="thumbnail">
            <img src="https://picsum.photos/1920/1080?random=${i}" alt="thumbnail">
        </a>
        <!-- Share buttons overlay -->
        <div class="overlay">
            <!-- Twitter share button -->
            <div class="twitter-share">
                <a onclick="window.open('https://twitter.com/intent/tweet?text=Come%20look%20at%20this%20post%20on%20PicRoll!%20'+encodeURIComponent(location.href));">
                    <img src="https://image.flaticon.com/icons/png/512/124/124021.png" alt="twitter logo">
                </a>
            </div>
            <!-- Facebook Share button -->
            <div class="facebook-share">
                <a onclick="window.open('https://www.facebook.com/sharer/sharer.php?u='+encodeURIComponent(location.href),'facebook-share-dialog','width=626,height=436');return false;">
                    <img src="https://images.squarespace-cdn.com/content/v1/54da6a67e4b09d1727ef4350/1501937173497-QAHHV3SX7K9CLJJMLYGA/ke17ZwdGBToddI8pDm48kNgFyjlEyNHlSWEjE-QCU1p7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1UXHo_8CK9SnlcV2kbFodiP5bD3dB3UuPmjUQ5AcQK7S0bSexTd1-frD7527z4SM9QQ/facebook+logo+png+transparent+background.png"
                        alt="facebook logo">
                </a>
            </div>
        </div>
        <!-- Title of post -->
        <h4 class="thumbnail-title thumbnail-text">${title}</h4>
        <!-- Description of post -->
        <p class="short-description thumbnail-text">${description}</p>`
        container[0].appendChild(element)
    }

    HandlePageLoadDarkMode()
})()