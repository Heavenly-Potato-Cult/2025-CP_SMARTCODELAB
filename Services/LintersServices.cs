using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SmartCodeLab.Services
{
    public class LintersServices
    {
        public readonly static Dictionary<string, string> javaLinters = new Dictionary<string, string>()
        {
            {ProgrammingConfiguration.checkstyleReadability,
                """
                <?xml version="1.0"?>
                <!DOCTYPE module PUBLIC
                    "-//Checkstyle//DTD Checkstyle Configuration 1.3//EN"
                    "https://checkstyle.org/dtds/configuration_1_3.dtd">

                <module name="Checker">
                	<module name="LineLength">
                		<property name="max" value="80"/> <!--The max will be based on how much the code editor can take without the need for scrolling horizontally -->
                	</module>
                    <module name="TreeWalker">
                		<!--WHITESPACED-->
                		<module name="GenericWhitespace"/>
                		<module name="MethodParamPad"/>
                		<module name="NoWhitespaceAfter">
                			<property name="allowLineBreaks" value="false"/>
                			<property name="tokens" value="DOT"/>
                		</module>
                		<module name="NoLineWrap"/>
                		<module name="NoWhitespaceBefore"/>
                		<module name="NoWhitespaceBeforeCaseDefaultColon"/>
                		<module name="OperatorWrap"/>
                		<module name="ParenPad"/> <!--FOR REVIEWAL-->
                		<module name="SeparatorWrap"/>
                		<module name="SingleSpaceSeparator"/>
                		<module name="TypecastParenPad"/>

                		<!--NAMING CONVENTIONS-->
                		<module name="AbbreviationAsWordInName"/>
                		<module name="CatchParameterName"/>
                		<module name="ConstantName"/>
                		<module name="InterfaceTypeParameterName"/>
                		<module name="LambdaParameterName"/>
                		<module name="LocalFinalVariableName">
                       			<property name="format" value="^[a-z][a-zA-Z0-9]*$"/>
                    		</module>
                		<module name="LocalVariableName"/>
                		<module name="MemberName"/>
                		<module name="MethodName"/>
                		<module name="ParameterName"/>
                		<module name="PatternVariableName"/>
                		<module name="StaticVariableName"/>

                		<!--MISCELLANEOUS-->
                		<module name="Indentation"/>
                		<module name="CommentsIndentation"/>

                		<!--CODING-->
                		<module name="UnusedImports"/>
                		<module name="OneStatementPerLine"/>
                		<module name="DefaultComesLast"/>
                		<module name="EmptyStatement">
                			<message key="empty.statement" value="Either put some statements inside or remove this block"/>
                		</module>
                    	<module name="MultipleVariableDeclarations"/>
                		<module name="OneStatementPerLine"/>
                		<module name="OverloadMethodsDeclarationOrder"/>
                		<module name="ParameterAssignment"/><!--FOR REVIEWAL-->
                		<module name="RequireThis"/>
                		<module name="ReturnCount">
                      		<property name="max" value="3"/>
                    	</module>
                		<module name="UnnecessaryParentheses"/>
                		<module name="UnnecessarySemicolonAfterTypeMemberDeclaration"/>
                    	<module name="UnnecessarySemicolonInTryWithResources"/>
                    	<module name="UnusedCatchParameterShouldBeUnnamed"/>
                		<module name="UnusedLocalVariable"/>
                    </module>
                </module>
                """},
            {ProgrammingConfiguration.checkstyleMaintainability,
                """
                <?xml version="1.0"?>
                <!DOCTYPE module PUBLIC
                    "-//Checkstyle//DTD Checkstyle Configuration 1.3//EN"
                    "https://checkstyle.org/dtds/configuration_1_3.dtd">

                <module name="Checker">
                	<module name="TreeWalker">
                    	<module name="NestedForDepth"/>
                    	<module name="NestedIfDepth"/>
                    	<module name="NestedTryDepth"/>
                    	<module name="BooleanExpressionComplexity"/>
                	<module name="UnusedLocalVariable"/>
                	<module name="ParameterNumber">
                		<property name="max" value="4"/>
                	</module>
                	<module name="NestedForDepth">
                		<property name="max" value="2"/>
                		<message key="nested.for.depth"
                				value="Your code contains deeply nested loops. Try breaking down the logic into smaller functions, or avoid multiple levels of nested loops to improve readability and performance."/>
                	</module>
                	<module name="NestedIfDepth">
                		<property name="max" value="3"/>
                		<message key="nested.if.depth"
                				value="Consider simplifying your conditions, using 'else if', or moving inner logic into helper methods for better readability."/>
                	</module>
                	<module name="NestedTryDepth"/>
                	<module name="SimplifyBooleanExpression"/>
                	<module name="SimplifyBooleanReturn"/>
                    <module name="CyclomaticComplexity">
                        <property name="max" value="999"/>
                    </module>
                  	</module>
                </module>
                """},
            {ProgrammingConfiguration.pmdRobustness,
                """
                <?xml version="1.0"?>
                <ruleset name="Performance Rules"
                    xmlns="http://pmd.sourceforge.net/ruleset/2.0.0"
                    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                    xsi:schemaLocation="http://pmd.sourceforge.net/ruleset/2.0.0 https://pmd.sourceforge.io/ruleset_2_0_0.xsd">

                    <description>
                        SmartCodeLab Robustness rules
                    </description>

                    <rule ref="category/java/errorprone.xml/BrokenNullCheck" />
                    <rule ref="category/java/errorprone.xml/CompareObjectsWithEquals" />
                    <rule ref="category/java/errorprone.xml/EqualsNull" />
                    <rule ref="category/java/errorprone.xml/MisplacedNullCheck" />
                    <rule ref="category/java/errorprone.xml/UnusedNullCheckInEquals" />
                    <rule ref="category/java/errorprone.xml/ReturnEmptyCollectionRatherThanNull" />
                    <rule ref="category/java/errorprone.xml/UseEqualsToCompareStrings" />
                </ruleset>
                """}
        };
        public readonly static Dictionary<string, string> pythonLinters = new Dictionary<string, string>()
        {
            {ProgrammingConfiguration.ruffReadability,
                """
                # ruff_config.toml - standalone
                output-format = "concise"
                preview = true
                lint.select = [	#naming convention
                		"N801", "N802", "N803", "N804", "N805", "N806", "N807", 
                    	"N811", "N812", "N813", "N814", "N815", "N816", "N817", 
                    	"N818", "N999",
                		#unnecessary whitespaces
                		"E201", "E202", "E203", "E211", "E225", "E226", "E227",
                		"E228", "E231", "E252", "E275", "W291", "W293", "E306", 
                		"E301",	"E114", "E115", "E116", "E701", "E702",
                		"RET504",	#unnecessary assignment
                		"F823",		#undefined-local
                		"PLR6104",	#non-augmented-assignment
                		"PLW0642",	#self-or-cls-assignment
                		"RUF018",	#assignment-in-assert
                		"FURB187",	#list-reverse-copy -- optional for now
                		"E301",		#blank-line-between-methods //TO ADD READABILITY
                		"SIM102",	#collapsible-if //TO ADD
                		"SIM202",
                		"PLW3301",	#nested-min-max
                		"F406",		#undefined-local-with-nested-import-star-usage
                		"PLR2044",
                ]
                line-length = 100
                target-version = "py310"

                [format]
                quote-style = "double"
                """ },
            {ProgrammingConfiguration.ruffMaintainability,
                """
                # ruff_config.toml - standalone
                output-format = "concise"
                preview = true
                lint.select = [	
                	"B014", "B025", "B033",
                	"PIE794", "PYI062",
                	"SIM101",
                	"PLE0241",
                	"PLR0913", "PLR0911", "PLR0915", "PLR2004",
                	"ARG001", "ARG002", "ARG003", "ARG004", "ARG005",
                    "C901"
                ]
                target-version = "py310"
                lint.mccabe.max-complexity = 999
                [format]
                quote-style = "double"
                """},
            {ProgrammingConfiguration.ruffRobustness,
                """
                # ruff_config.toml - standalone
                output-format = "concise"
                preview = true
                lint.select = [
                "F632",
                "E721",
                "E722",
                "TRY004",
                "TRY201",
                "TRY002",
                "TRY003",
                "TRY203",
                "TRY300",
                "TRY301"
                ]
                target-version = "py310"
                """}
        };

        public static void initializeLinter(string filepath, string content)
        {
            File.WriteAllText(filepath, content, Encoding.UTF8);
        }
    }
}
