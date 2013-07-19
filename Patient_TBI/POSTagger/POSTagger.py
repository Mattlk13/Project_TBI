"""
POSTagger: To tag questions in the question.txt file with parts of speech
Date: 07/18/2013
Author: Raghavi Sakpal
"""
import nltk

# Function: To read the question.txt file for questions
def readQuestion():

    # Open a file to read
    questionFile = open('question.txt','r')

    # Open a file to write
    tagFile = open('keyword.txt', 'w')

    for line in questionFile:
        tagDict = createTagDict(line)
        tagFile.write(line)

        # Write these tags to the output file
        for k in tagDict:
            if k[1] == 'NN' or k[1] == 'NNP' or k[1] == 'NNS' or k[1] == 'NNPS' or k[1] == 'WRB':
                tagFile.write(k[0])
                tagFile.write(',')
        tagFile.write('\n\n')

    # Close the files
    tagFile.close()
    questionFile.close()

# Function: Using nltk POS taggers to return a Dict
def createTagDict(question):
    tagText = nltk.word_tokenize(question)
    tagDict = nltk.pos_tag(tagText)

    return tagDict

readQuestion()
print ("Done")