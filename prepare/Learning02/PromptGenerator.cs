using System;

class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        // Initialize with some example prompts
        prompts = new List<string>
        {
            "Who inspired you the most today, and how did they do it?",
            "What unexpected joy did you find in the mundane moments of today?",
            "If you were given a chance to meet the Prophet what question would you ask?",
            "In what ways did you practice self-care today?",
            "Describe a decision you made today and its impact on your well-being.",
            "What lesson did failure teach you today, and how will you apply it?",
            "Share a dream or aspiration that crossed your mind today.",
            "How did you contribute to a positive atmosphere today?",
            "Reflect on a conversation that broadened your perspective today.",
            "Write about an item or possession that holds sentimental value for you.",
            "What skill or talent did you witness in someone today that impressed you?",
            "If you could offer advice to your future self, what would it be?",
            "What aspect of nature brought you peace or awe today?",
            "Describe a moment when you felt completely in the present today.",
            "Share a memory from your past that resurfaced in your thoughts today.",
            "Reflect on a decision you made based on intuition rather than logic.",
            "Write about a place from your childhood that holds fond memories.",
            "What habit or routine positively impacted your day?",
            "If you could collaborate with someone on a creative project, who would it be and why?",
            "How did you handle a stressful situation today, and what did you learn from it?",
            "What cultural experience or tradition did you engage with today?",
            "Write about a compliment you received today and its impact on you.",
            "Reflect on a fear or insecurity you faced today and how you overcame it.",
            "If you could have a conversation with your future self, what would you ask?",
            "Describe a moment when you felt a deep sense of gratitude today.",
            "What metaphor or symbol best represents your day today?",
            "How did you prioritize your time and energy today?",
            "Write about a piece of advice you received that stuck with you today.",
            "Reflect on a decision you made that aligned with your values.",
            "What accomplishment, big or small, are you most proud of from today?",
            "If today were a chapter in your life story, how would you title it?",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}